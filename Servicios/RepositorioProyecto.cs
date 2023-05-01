using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyecto
    {
        List<Proyecto> obtenerProyectos();
    }
    public class RepositorioProyecto: IRepositorioProyecto
    {
        public List<Proyecto> obtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto()
                {
                    titulo="Aplicativo de Notas",
                    descripcion="Aplicativo Web FullStack de creación de notas, realizado con la librería 'Redux'",
                    imagenUrl="/imagenes/notas.png",
                    link="https://dana-dev.netlify.app"
                },
                new Proyecto()
                {
                    titulo="Coins App",
                    descripcion="Consumo de API de criptomonedas, Front-End Realizado con React.js",
                    imagenUrl="/imagenes/coins.png",
                    link="https://criptomonedasearcher.netlify.app"
                },
                new Proyecto()
                {
                    titulo="Socket Notes",
                    descripcion="Aplicativo Web FullStack utilizando de modelo API WebSocket",
                    imagenUrl="/imagenes/notes.png",
                    link="https://socketnotes.netlify.app/"
                },
                new Proyecto()
                {
                    titulo="Aplicativo de Notas",
                    descripcion="Aplicativo Web FullStack de creación de notas, realizado con la librería 'Redux'",
                    imagenUrl="/imagenes/notas.png",
                    link="https://dana-dev.netlify.app"
                },
                new Proyecto()
                {
                    titulo="Coins App",
                    descripcion="Consumo de API de criptomonedas, Front-End Realizado con React.js",
                    imagenUrl="/imagenes/coins.png",
                    link="https://criptomonedasearcher.netlify.app"
                },
                new Proyecto()
                {
                    titulo="Socket Notes",
                    descripcion="Aplicativo Web FullStack utilizando de modelo API WebSocket",
                    imagenUrl="/imagenes/notes.png",
                    link="https://socketnotes.netlify.app/"
                },

            };
        }

    }
}
