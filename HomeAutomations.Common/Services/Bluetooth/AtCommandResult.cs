namespace HomeAutomations.Common.Services.Bluetooth;

public abstract class AtCommandResult
{

}

// Determine type by checking against JSON schemas of DTOs:
public class MyDto
{
	[JsonProperty(Required = Required.Always)]
	public bool MyProp { get; set; }
}


var generator = new JSchemaGenerator();
var schema = generator.Generate(typeof(MyDto));
var dto = JObject.Parse(@"{ 'MyProp': true }");
bool isValid = dto.IsValid(schema);
Console.WriteLine(isValid); // True

dto = JObject.Parse(@"{}");
isValid = dto.IsValid(schema);
Console.WriteLine(isValid); // False
