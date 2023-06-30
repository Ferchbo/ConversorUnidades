using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_unidades
{
    public class ConvertirServicio
    {
        public double convertirMasa(MasaNumeracion desde, MasaNumeracion hacia, double cantidad)
        {
            double valorConvertido = 0;

            switch (desde)
            {
                case MasaNumeracion.Miligramos:
                    {
                        switch (hacia)
                        {
                            case MasaNumeracion.Gramos:
                                valorConvertido = cantidad / 100;
                                break;
                            case MasaNumeracion.Kilogramos:
                                valorConvertido = cantidad / 1000000;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case MasaNumeracion.Gramos:
                    {
                        switch (hacia)
                        {
                            case MasaNumeracion.Miligramos:
                                valorConvertido = cantidad * 1000;
                                break;
                            case MasaNumeracion.Kilogramos:
                                valorConvertido = cantidad / 1000;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case MasaNumeracion.Kilogramos:
                    {
                        switch (hacia)
                        {
                            case MasaNumeracion.Gramos:
                                valorConvertido = cantidad * 1000;
                                break;
                            case MasaNumeracion.Miligramos:
                                valorConvertido = cantidad * 1000000;
                                break;
                            default:
                                break;
                        }
                    }
                    break;

            }




            return valorConvertido;
        }
        public double convertirTemperatura(TemperaturaNumeracion desde, TemperaturaNumeracion hacia, double cantidad)
        {
            double valorConvertido = 0;

            switch (desde)
            {
                case TemperaturaNumeracion.Celsius:
                    {
                        switch (hacia)
                        {
                            case TemperaturaNumeracion.Fahrenheit:
                                valorConvertido = (cantidad * 1.8) + 32;
                                break;
                            case TemperaturaNumeracion.Kelvin:
                                valorConvertido = cantidad + 273.15;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case TemperaturaNumeracion.Kelvin:
                    {
                        switch (hacia)
                        {
                            case TemperaturaNumeracion.Celsius:
                                valorConvertido = cantidad - 273.15;
                                break;
                            case TemperaturaNumeracion.Fahrenheit:
                                valorConvertido = (cantidad - 273.15)* 1.8 + 32;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case TemperaturaNumeracion.Fahrenheit:
                    {
                        switch (hacia)
                        {
                            case TemperaturaNumeracion.Kelvin:
                                valorConvertido = (cantidad - 32) * 1.8 + 273.15;
                                break;
                            case TemperaturaNumeracion.Celsius:
                                valorConvertido = (cantidad - 32) * 1.8;
                                break;
                            default:
                                break;
                        }
                    }
                    break;

            }




            return valorConvertido;
        }

        public double convertirTiempo(TiempoNumeracion desde, TiempoNumeracion hacia, double cantidad)
        {
            double valorConvertido = 0;

            switch (desde)
            {
                case TiempoNumeracion.Milisegundos:
                    {
                        switch(hacia)
                        {
                            case TiempoNumeracion.segundos:
                            {
                                    valorConvertido = cantidad / 1000;
                            }
                            break;
                            case TiempoNumeracion.Minutos:
                                {
                                    valorConvertido = cantidad / 60000;
                                }
                                break;
                            case TiempoNumeracion.Horas:
                                {
                                    valorConvertido = cantidad / 3600000;
                                }
                                break;
                           default:
                                break;
                        }
                    }
                    break;
                case TiempoNumeracion.segundos:
                    {
                        switch (hacia)
                        {
                            case TiempoNumeracion.Milisegundos:
                                {
                                    valorConvertido = cantidad * 100;
                                }
                                break;
                            case TiempoNumeracion.Minutos:
                                {
                                    valorConvertido = cantidad / 60;
                                }
                                break;
                            case TiempoNumeracion.Horas:
                                {
                                    valorConvertido = cantidad / 3600;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case TiempoNumeracion.Minutos:
                    {
                        switch (hacia)
                        {
                            case TiempoNumeracion.Milisegundos:
                                {
                                    valorConvertido = cantidad * 60000;
                                }
                                break;
                            case TiempoNumeracion.segundos:
                                {
                                    valorConvertido = cantidad * 60;
                                }
                                break;
                            case TiempoNumeracion.Horas:
                                {
                                    valorConvertido = cantidad / 60;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case TiempoNumeracion.Horas:
                    {
                        switch (hacia)
                        {
                            case TiempoNumeracion.Milisegundos:
                                {
                                    valorConvertido = cantidad * 3600000;
                                }
                                break;
                            case TiempoNumeracion.segundos:
                                {
                                    valorConvertido = cantidad * 3600;
                                }
                                break;
                            case TiempoNumeracion.Minutos:
                                {
                                    valorConvertido = cantidad * 60;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }

            return valorConvertido;
            
        }
    }
}
