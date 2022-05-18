//const data = JSON.parse(args.shortcutParameter);
const data = args.shortcutParameter;
const date = new Date(data[data.length - 1].last_updated);

return date.toLocaleString('de-DE');
