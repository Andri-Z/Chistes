using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chistes
{
    public class Chistes
    {
        private readonly Random _random = new();
        public void GetChistes(string path,TipoChiste tipo)
        {
            try
            {
                string[] chistes = File.ReadAllLines(path);
                if (chistes.Length == 0)
                {
                    MessageBox.Show("No existen chistes para mostrar.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                int index = _random.Next(chistes.Length);
                Titulos.TryGetValue(tipo,out string? titulo);
                MessageBox.Show(chistes[index],titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error al buscar los chistes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string? GetPathChiste(TipoChiste tipo) => tipo switch
        {
            TipoChiste.ChistesMalos => Path.GetFullPath("Data\\ChistesMalos.txt"),
            TipoChiste.ChistesPapa => Path.GetFullPath("Data\\ChistesPapa.txt"),
            TipoChiste.ChistesTecnologia => Path.GetFullPath("Data\\ChistesTecnologia.txt"),
            TipoChiste.ChistesAnimales => Path.GetFullPath("Data\\ChistesAnimales.txt"),
            TipoChiste.ChistesCortos => Path.GetFullPath("Data\\ChistesCortos.txt"),
            _ => null
        };
        public void GenerateChiste(TipoChiste tipo)
        {
            var path = GetPathChiste(tipo);
            if (path is null)
                MessageBox.Show("Ha ocurrido un error al obtener el tipo de chiste.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                GetChistes(path,tipo);
        }
        private Dictionary<Enum, string> Titulos = new()
        {
            {TipoChiste.ChistesMalos,"Chiste Malo"},
            {TipoChiste.ChistesPapa, "Chiste de Papá"},
            {TipoChiste.ChistesTecnologia, "Chiste de Tecnología"},
            {TipoChiste.ChistesAnimales, "Chiste de Animales"},
            {TipoChiste.ChistesCortos, "Chiste Corto"}
        };
    }
}
