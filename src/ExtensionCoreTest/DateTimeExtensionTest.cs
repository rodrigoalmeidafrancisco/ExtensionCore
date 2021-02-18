using ExtensionCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExtensionCoreTest
{
    [TestClass]
    public class DateTimeExtensionTest
    {
        [TestMethod]
        public void Teste_ToDateTime()
        {
            DateTime dataAtual = DateTime.Now;

            string dataString = JsonExtension.ToSerializeJsonNewtonsoft(dataAtual);
            

        }

        [TestMethod]
        public void Teste_ToDateTimeNull()
        {



        }

        [TestMethod]
        public void Teste_ToDateTimeDayEnd()
        {



        }

        [TestMethod]
        public void Teste_ToDateTimeDayEnd_Null()
        {



        }
    }
}
