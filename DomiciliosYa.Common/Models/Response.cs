namespace DomiciliosYa.Common.Models
{
    public class Response
    {
        /*si fue o no exitosa la conexion*/
        public bool IsSuccess { get; set; }

        /*si no fue exitosa*/
        public string Message { get; set; }

        /*si es exitoso otra propiedad de tipo object ya que es generico*/
        public object Result { get; set; }
    }
}
