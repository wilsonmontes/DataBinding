using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataBinding
{
   public class Datos:Notificable
    {
        private ObservableCollection<Persona> personas;
        private Persona personaSeleccionada;

        public ObservableCollection<Persona> Personas
        {
            get {
                return personas;
            }
            set {
                if (personas == value)
                {
                    return;
                }
                personas = value;
                OnPropertyChanged();
            }
        }


        public Persona PersonaSeleccionada
        {
            get {
                return personaSeleccionada;
            }
            set {
                if (personaSeleccionada == value)
                {
                    return;
                }
                personaSeleccionada = value;
                OnPropertyChanged();
                
            }
        }

        #region Constructores
        public Datos()
        {
            Personas = new ObservableCollection<Persona>();
            for (int i = 0; i < 5; i++)
            {
                Personas.Add(new Persona()
                {
                    nombre = $"Persona {i}",
                    Pais = $"Pais{i}"
                });
            }
        }
        #endregion
    }
}
