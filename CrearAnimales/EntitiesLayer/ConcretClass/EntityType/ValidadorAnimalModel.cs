using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntitiesLayer.ConcretClass.EntityType
{
    public class ValidadorAnimalModel
    {
        public static IEnumerable<ValidationResult> ValidarObjeto(object obj)
        {
            var validacion = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, validacion, true);
            return validacion;
        }
    }
}
