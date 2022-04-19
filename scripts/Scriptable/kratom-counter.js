// Variables used by Scriptable.
// These must be at the very top of the file. Do not edit.
// icon-color: green; icon-glyph: glass-water;

// Change me!
// *******************
const config = {
	name: 'philipp',
	trackedName: 'Kratom',
	sensorPrefix: 'sensor.kratom_intake_',
	shortcutName: 'Kratom Eintragen',
	getAmountText: (amount) => {
		return `${amount} Tl`;
	},

	widgetBackgroundColor: '#3a7c33',
	graphPrimaryColor: 'rgb(73,210,58)',
	graphPrimaryColorHex: '#49D23A',
	graphSecondaryColor: 'rgb(91,166,70)'
};

let baseCounter = importModule('base-counter');
await baseCounter.createWidget(config);
