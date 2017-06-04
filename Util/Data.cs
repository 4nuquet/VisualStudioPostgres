using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Data
    {

        public string Convert(string key)
        {
            var keyConveted = "";

            switch (key)
            {
                case "nombre":
                    keyConveted = "name";
                    break;
                case "plataforma":
                    keyConveted = "platform";
                    break;
                case "estreno":
                    keyConveted = "release";
                    break;
                case "calificacion":
                    keyConveted = "rating";
                    break;
            }

            return keyConveted;
        }

        public string ConvertCategory(string category)
        {

            var categoryConverted="";

            switch (category)
            {
                case "accion":
                    categoryConverted = "action";
                    break;
                case "aventura":
                    categoryConverted = "adventure";
                    break;
                case "conduccion":
                    categoryConverted = "driving";
                    break;
                case "deporte":
                    categoryConverted = "sport";
                    break;
                case "estrategia":
                    categoryConverted = "strategy";
                    break;
                default:
                    categoryConverted = category;
                    break;
            }

            return categoryConverted;
        }

        public string convertRequire(string require)
        {
            var requireConverted = "";

            switch(require)
            {
                case "normal 1":
                    requireConverted = "1";
                    break;
                case "normal 2":
                    requireConverted = "2";
                    break;
                case "normal 3":
                    requireConverted = "3";
                    break;
                case "medios 1":
                    requireConverted = "4";
                    break;
                case "medios 2":
                    requireConverted = "5";
                    break;
                case "altos 1":
                    requireConverted = "6";
                    break;
                case "altos 2":
                    requireConverted = "7";
                    break;
                case "ultra 1":
                    requireConverted = "8";
                    break;
                case "ultra 2":
                    requireConverted = "9";
                    break;
            }

            return requireConverted;

        }

        public string convertNick(string category)
        {
            var nickConverted = "";

            switch (category)
            {
                case "accion":
                    nickConverted = "act";
                    break;
                case "aventura":
                    nickConverted = "adv";
                    break;
                case "conduccion":
                    nickConverted = "dri";
                    break;
                case "indie":
                    nickConverted = "ind";
                    break;
                case "moba":
                    nickConverted = "mob";
                    break;
                case "deporte":
                    nickConverted = "spo";
                    break;
                case "estrategia":
                    nickConverted = "str";
                    break;
                case "terror":
                    nickConverted = "ter";
                    break;
                default:
                    nickConverted = category;
                    break; 
            }

            return nickConverted;

        }

    }
}
