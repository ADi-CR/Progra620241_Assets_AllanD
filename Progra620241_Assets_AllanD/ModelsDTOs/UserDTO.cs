namespace Progra620241_Assets_AllanD.ModelsDTOs
{
    public class UserDTO
    {
        //Un DTO (data transfer object) sirve para varios objetivos. 

        //1. desacoplar el modelo de la funcionalidad de los controllers
        //para evitar que en futuras actualizaciones de los modelos 
        //puedan ocurrir errores dificiles de reparar. 

        //2. sirve para simplificar modelos muy complejos y que tienen
        //composiciones recursivas, muy comunes cuando se generan 
        //mediante ORM como Entity Framework, Dapper, Django...

        //3. Por un asunto de Seguridad. Ya que normalmente los equipos
        //de desarrollo de las apps y web apis están separados, y no 
        //se quiere que los programadores de front end sepan cómo está
        //estructurada la base de datos tomando como base los modelos. 

        public int CodigoUsuario { get; set; }

        public string Cedula { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string? Telefono { get; set; }

        public string? Direccion { get; set; }

        public string Correo { get; set; } = null!;

        //en este ejemplo no usaremos la contraseña ya que este DTO
        //será usado para mostrar la lista de usuarios en una UI
        //tendremos otra versión de DTO que si tiene la contraseña 
        //para cuando querramos agregar un usuario.

        //public string Contrasennia { get; set; } = null!;

        public bool? Activo { get; set; }

        public int CodigoDeRol { get; set; }

        public string? RolDeUsuario { get; set; }

        public string? NotasDelUsuario { get; set; }

        //acá se pueden agregar los atribs que sean necesarios

    }
}
