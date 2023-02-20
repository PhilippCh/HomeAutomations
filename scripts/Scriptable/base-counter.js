module.exports.createWidget = async function(config) {
    const req = new Request("https://ha.pupslab.de/api/states")
    req.headers = {
        "Authorization": "Bearer REMOVED",
        "content-type": "application/json"
    }
    const json = await req.loadJSON();

    /* Parse data received from API */
	const sensorName = `${config.sensorPrefix}${config.name}`;
    const data = {
        today: Number(getSensorData(json, sensorName, 0)),
        target: Number(getSensorData(json, `${config.sensorPrefix}${config.name}_target`, 0)),
		lastUpdated: getSensorLastUpdated(json, sensorName),
		lastIncrement: getSensorAttribute(json, sensorName, 'last_increment')
    }

    const widget = new ListWidget();
    const nextRefresh = Date.now() + 1000 * 30 // add 30 second to now.

    widget.refreshAfterDate = new Date(nextRefresh);
    widget.url = `shortcuts://run-shortcut?name=${encodeURI(config.shortcutName)}`;
    widget.useDefaultPadding()
    widget.backgroundColor = new Color(config.widgetBackgroundColor, 1.0);

    await createBody(widget, data, config);

	if (!config.runsInWidget) {
		await widget.presentSmall();
	}

	Script.setWidget(widget);
	Script.complete();

}

async function loadImage(imgUrl) {
    const req = new Request(imgUrl)
    return await req.loadImage()
}

function getSensor(json, sensor, defaultValue) {
	const sensors = json.filter(x => x.entity_id === sensor);

	if (sensors.length === 0 || sensors.length > 1) {
		return undefined;
	}

	return sensors[0];
}

function getSensorData(json, sensor, defaultValue) {
    return getSensor(json, sensor)?.state ?? defaultValue;
}

function getSensorLastUpdated(json, sensor) {
	return getSensor(json, sensor)?.last_changed ?? undefined;
}

function getSensorAttribute(json, sensor, attribute) {
	return getSensor(json, sensor)?.attributes[attribute] ?? undefined;
}

function addLabel(bodyStack, config, text) {
	const labelStack = bodyStack.addStack();
	labelStack.layoutHorizontally();
	labelStack.size = new Size(getWidgetSize(0).width, 0);
	labelStack.addSpacer();
	const label = labelStack.addText(text);
	label.textColor = new Color(config.graphPrimaryColorHex);
	labelStack.addSpacer();
}

async function createBody(widget, data, config) {
    const bodyStack = widget.addStack();
    bodyStack.layoutVertically();
    bodyStack.centerAlignContent();

    const progress = (data.today / data.target) * 100;

    const chartUrl = 'https://quickchart.io/chart?c=';
    const chartData = {
        type: 'radialGauge',
        options: {
            centerArea: {
                text: `${Math.round(progress)}%`,
                fontColor: config.graphPrimaryColor,
                fontSize: 64
            },
            trackColor: config.graphSecondaryColor
        },
        data: {
            datasets: [{
                data: [progress],
                backgroundColor: config.graphPrimaryColor,
                borderColor: config.graphPrimaryColor
            }]
        }
    };

	addLabel(bodyStack, config, config.trackedName);

    const requestUrl = encodeURI(`${chartUrl}${JSON.stringify(chartData)}`);
    const chartImage = await loadImage(requestUrl);
    const chart = bodyStack.addImage(chartImage);
    chart.imageSize = getWidgetSize(50);

	addLabel(bodyStack, config, `${config.getAmountText(data.today)} of ${config.getAmountText(data.target)}`);
	addLabel(bodyStack, config, `${data.lastUpdated} (${data.lastIncrement})`);
}

function getWidgetSize(marginBottom) {
    const deviceScreen = Device.screenSize();
    const padding = ((deviceScreen.width - 240) / 5);

    return new Size(padding + 120, padding + 120 - marginBottom);
}
