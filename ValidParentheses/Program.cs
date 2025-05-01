using System.ComponentModel.DataAnnotations;
using ValidParentheses.Algorithm;

//ItemValidatorV1 validator1 = new();
ItemValidatorV2 validator2 = new();

//Console.WriteLine(validator1.IsValid("(){}}{"));
Console.WriteLine(validator2.IsValid("(){}}{"));