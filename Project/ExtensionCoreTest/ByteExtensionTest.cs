using ExtensionCore;
using ExtensionCoreTest.Commum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionCoreTest
{
    [TestClass]
    public class ByteExtensionTest
    {
        public byte valbyteReturn;
        public byte[] valbyteArrayReturn;

        public ByteExtensionTest()
        {
            valbyteReturn = 0;
            valbyteArrayReturn = null;
        }

        [TestMethod]
        public void Test_ToByte_String()
        {
            string val = "5";
            valbyteReturn = val.ToByte();
            Assert.AreEqual(5, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(val);
            Assert.AreEqual(5, valbyteReturn);

            val = "";
            valbyteReturn = val.ToByte();
            Assert.AreEqual(0, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(val);
            Assert.AreEqual(0, valbyteReturn);

            val = "  ";
            valbyteReturn = val.ToByte();
            Assert.AreEqual(0, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(val);
            Assert.AreEqual(0, valbyteReturn);

            val = "Teste";
            valbyteReturn = val.ToByte();
            Assert.AreEqual(0, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(val);
            Assert.AreEqual(0, valbyteReturn);

            val = string.Empty;
            valbyteReturn = val.ToByte();
            Assert.AreEqual(0, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(val);
            Assert.AreEqual(0, valbyteReturn);

            val = null;
            valbyteReturn = val.ToByte();
            Assert.AreEqual(0, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(val);
            Assert.AreEqual(0, valbyteReturn);
        }

        [TestMethod]
        public void Test_ToByte_Object()
        {
            object valString = "5";
            valbyteReturn = valString.ToByte();
            Assert.AreEqual(5, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(valString);
            Assert.AreEqual(5, valbyteReturn);

            object valInt = int.MaxValue;
            valbyteReturn = valInt.ToByte();
            Assert.AreEqual(0, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(valInt);
            Assert.AreEqual(0, valbyteReturn);
        }

        [TestMethod]
        public void Test_ToByte_Enum()
        {
            valbyteReturn = EnumTest.Teste0.ToByte();
            Assert.AreEqual(0, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(EnumTest.Teste0.ToByte());
            Assert.AreEqual(0, valbyteReturn);

            valbyteReturn = EnumTest.Teste1.ToByte();
            Assert.AreEqual(1, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(EnumTest.Teste1.ToByte());
            Assert.AreEqual(1, valbyteReturn);

            valbyteReturn = EnumTest.Teste2.ToByte();
            Assert.AreEqual(2, valbyteReturn);
            valbyteReturn = ByteExtension.ToByte(EnumTest.Teste2.ToByte());
            Assert.AreEqual(2, valbyteReturn);
        }

        [TestMethod]
        public void Test_ImageScale()
        {
            valbyteArrayReturn = valbyteArrayReturn.ImageScale(2);
            Assert.AreEqual(null, valbyteArrayReturn);
            valbyteArrayReturn = ByteExtension.ImageScale(null, 2);
            Assert.AreEqual(null, valbyteArrayReturn);
        }

        [TestMethod]
        public void Test_ToPathByteArray()
        {
            string pathFile = null;
            valbyteArrayReturn = pathFile.ToPathByteArray();
            Assert.AreEqual(null, valbyteArrayReturn);
            valbyteArrayReturn = ByteExtension.ToPathByteArray(pathFile);
            Assert.AreEqual(null, valbyteArrayReturn);



        }

    }
}
