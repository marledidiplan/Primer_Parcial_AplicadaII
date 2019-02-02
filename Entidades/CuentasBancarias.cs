﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentasBancarias
    {
        [Key]
        public int CuentaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public decimal Balance { get; set; }

        public CuentasBancarias()
        {
            CuentaId = 0;
            Fecha = DateTime.Now;
            Nombre = string.Empty;
            Balance = 0;
        }
        public CuentasBancarias(int cuentaId, DateTime fecha, string nombre, decimal balance)
        {
            CuentaId = cuentaId;
            Fecha = fecha;
            Nombre = nombre;
            Balance = balance;
        }
    }
}
