using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrearAnimales.EntitiesLayer.ConcretClass.EntityType
{
    public class ValidadorAnimalModel
    {
        public List<ValidationResult> ValidarObjeto(Animal animal)
        {
            var validacion = new List<ValidationResult>();
            var contexto = new ValidationContext(animal);
            Validator.TryValidateObject(animal, contexto, validacion, true);
            return validacion;
        }
    }
}
