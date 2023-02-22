// Variables used by Scriptable.
// These must be at the very top of the file. Do not edit.
// icon-color: purple; icon-glyph: magic;
﻿const data = args.shortcutParameter;
const date = new Date(data.last_changed);

function getAmountText(amount) {
  return amount < 1000 ? `${amount}ml` : `${Math.round(amount / 1000 * 10) / 10}l`;
}

return {
  date: date.toLocaleString('de-DE'),
  increment: getAmountText(data.attributes.last_increment)
}
