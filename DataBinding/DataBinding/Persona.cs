namespace DataBinding
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;
    public class Persona:Notificable
    {
        public string nombre;
        public string pais;
        #region propiedades
        public String Nombre
        {
            get {
                return nombre;
            }
            set
            {
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged();
            }
        }
        public String Pais
        {
            get
            {
                return pais;
            }
            set
            {
                if (pais == value)
                {
                    return;
                }
                pais = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region Metodos
        public override string ToString()
        {
            return $"{Nombre} | {Pais}";
        }
        #endregion
    }
}
