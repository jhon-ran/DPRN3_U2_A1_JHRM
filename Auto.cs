using System;
using System.Collections.Generic;
using System.Text;

namespace DPRN3_U2_A1_JHRM
{
    class Auto
    {
        //Atributos de cada auto
        private string tipo_vehiculo;
        private string serie;
        private int ano_adq;
        private string marca;
        private string modelo;
        private int ano_vehiculo;
        private string color;
        private string verificacion;
        private byte[] foto;


        //Constructor
        public Auto()
        {
            //Se inicializan los atributos vacios
            this.tipo_vehiculo = "";
            this.serie = "";
            this.ano_adq = 0;
            this.marca = "";
            this.modelo = "";
            this.ano_vehiculo = 0;
            this.color = "";
            this.verificacion = "";
            this.foto = null;

        }



        //Métodos Get Set para acceder y modificar datos
        public string Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }
        public string Serie { get => serie; set => serie = value; }
        public int Ano_adq { get => ano_adq; set => ano_adq = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Ano_vehiculo { get => ano_vehiculo; set => ano_vehiculo = value; }
        public string Color { get => color; set => color = value; }
        public string Verificacion { get => verificacion; set => verificacion = value; }
        public byte[] Foto { get => foto; set => foto = value; }

    }
}
