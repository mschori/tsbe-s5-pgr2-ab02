using System.ComponentModel.DataAnnotations;

namespace Exercise_07;

public static class ObjectValidator
{
    public static bool Validate<T>(T obj)
    {
        if (obj == null)
        {
            return false;
        }

        var vContext = new ValidationContext(obj);
        var vResults = new List<ValidationResult>();
        var isValid = Validator.TryValidateObject(obj, vContext, vResults, true);
        if (!isValid)
        {
            foreach (var validationResult in vResults)
            {
                Console.WriteLine("{0}", validationResult.ErrorMessage);
            }
        }

        return isValid;
    }
}