using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace WarehouseEntity
{
    public class Validator
    {
        public static IEnumerable<string> Validate(object o)
        {
            Type type = o.GetType();
            PropertyInfo[] properties = o.GetType().GetProperties();

            foreach (var propertyInfo in properties)
            {
                object[] customAttributes = propertyInfo.GetCustomAttributes(typeof (ValidationAttribute), true);

                foreach (var customAttribute in customAttributes)
                {
                    var validationAttribute = (ValidationAttribute) customAttribute;

                    bool isValid =
                        validationAttribute.IsValid(propertyInfo.GetValue(o, BindingFlags.GetProperty, null, null, null));

                    if (!isValid)
                    {
                        yield return validationAttribute.ErrorMessage;
                    }
                }
            }
        }

        public void CheckValid(Object o)
        {
            var results = Validate(o);
            var enumerable = results as string[] ?? results.ToArray();
            if (enumerable.Any())
            {
                enumerable.ToList().ForEach(error => { if (error != null) throw new Exception(error); });
            }
        }
    }
}

