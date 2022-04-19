// Variables used by Scriptable.
// These must be at the very top of the file. Do not edit.
// icon-color: blue; icon-glyph: glass-water;
let widget = await createWidget();
if (!config.runsInWidget) {
    await widget.presentSmall();
}

Script.setWidget(widget);
Script.complete();

async function createWidget(items) {

    // Change me!
    // *******************
    const config = {
        name: 'philipp',
        sensorPrefix: 'sensor.water_intake_',
        shortcutName: 'Ich Habe Getrunken',

        widgetBackgroundColor: '#335b7c',
        graphPrimaryColor: 'rgb(58, 140, 210)',
        graphPrimaryColorHex: '#3A8CD2FF',
        graphSecondaryColor: 'rgb(70,122,166)'
    };

    const req = new Request("https://ha.pupslab.de/api/states")
    req.headers = {
        "Authorization": "Bearer REMOVED",
        "content-type": "application/json"
    }
    const json = await req.loadJSON();

    /* Parse data received from API */
    const data = {
        today: Number(getSensorData(json, `${config.sensorPrefix}${config.name}`, 0)),
        target: Number(getSensorData(json, `${config.sensorPrefix}${config.name}_target`, 0))
    }

    const widget = new ListWidget();
    const nextRefresh = Date.now() + 1000 * 30 // add 30 second to now.

    widget.refreshAfterDate = new Date(nextRefresh);
    widget.url = `shortcuts://run-shortcut?name=${encodeURI(config.shortcutName)}`;
    widget.useDefaultPadding()
    widget.backgroundColor = new Color(config.widgetBackgroundColor, 1.0);

    await createBody(widget, data, config);

    return widget;
}

async function loadImage(imgUrl) {
    const req = new Request(imgUrl)
    return await req.loadImage()
}

function getSensorData(json, sensor, defaultValue) {
    const sensors = json.filter(x => x.entity_id === sensor);

    if (sensors.length === 0 || sensors.length > 1) {
        return defaultValue;
    }

    return sensors[0].state;
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

    const requestUrl = encodeURI(`${chartUrl}${JSON.stringify(chartData)}`);
    const chartImage = await loadImage(requestUrl);
    const chart = bodyStack.addImage(chartImage);
    chart.imageSize = getWidgetSize(40);

    const labelStack = bodyStack.addStack();
    labelStack.layoutHorizontally();
    labelStack.size = new Size(getWidgetSize(0).width, 0);
    labelStack.addSpacer();
    const label = labelStack.addText(`${getAmountText(data.today)} of ${getAmountText(data.target)}`);
    label.textColor = new Color(config.graphPrimaryColorHex);
    labelStack.addSpacer();
}

function getAmountText(amount) {
    return amount < 1000 ? `${amount}ml` : `${Math.round(amount / 1000 * 10) / 10}l`;
}

function getWidgetSize(marginBottom) {
    const deviceScreen = Device.screenSize();
    const padding = ((deviceScreen.width - 240) / 5);

    return new Size(padding + 120, padding + 120 - marginBottom);
}
