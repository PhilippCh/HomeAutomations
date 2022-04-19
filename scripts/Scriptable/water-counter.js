// Variables used by Scriptable.
// These must be at the very top of the file. Do not edit.
// icon-color: blue; icon-glyph: glass-water;

// Change me!
// *******************
const config = {
	name: 'philipp',
	trackedName: 'Wasser',
	sensorPrefix: 'sensor.water_intake_',
	shortcutName: 'Getränk Eintragen',
	getAmountText: (amount) => {
		return amount < 1000 ? `${amount}ml` : `${Math.round(amount / 1000 * 10) / 10}l`;
	},

	widgetBackgroundColor: '#335b7c',
	graphPrimaryColor: 'rgb(58, 140, 210)',
	graphPrimaryColorHex: '#3A8CD2FF',
	graphSecondaryColor: 'rgb(70,122,166)'
};

let baseCounter = importModule('base-counter');
await baseCounter.createWidget(config);
