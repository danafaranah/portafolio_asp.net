namespace Portafolio.Servicios
{
    public class ServicioUnico
    {
        public ServicioUnico() 
        {
            //Guid es un string aleatorio largo
            obtenerGuid = Guid.NewGuid();
        }

        public Guid obtenerGuid { get; private set; }
        
    }

    public class ServicioDelimitado 
    {
        public ServicioDelimitado()
        {
            obtenerGuid = Guid.NewGuid();
        }
        public Guid obtenerGuid { get;private set; }

    }

    public class ServicioTransitorio
    {
        public ServicioTransitorio()
        {
            obtenerGuid = Guid.NewGuid();
        }
        public Guid obtenerGuid { get; private set; }
    }
}
