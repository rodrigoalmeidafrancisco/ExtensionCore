﻿using ExtensionCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace ExtensionCoreTest
{
    [TestClass]
    public class DateTimeExtensionTest
    {
        private DateTime _date;
        private DateTime? _dateNull;
        private string _dataString;

        public DateTimeExtensionTest()
        {

        }

        [TestMethod]
        public void Teste_ToDateTime()
        {
            _dataString = "25/02/2021"; 
            _date = _dataString.ToDateTime(new CultureInfo("pt-BR"));
            Assert.AreEqual(_date, new DateTime(2021,02,25));

            _dataString = "25/02/2021 18:30:20"; 
            _date = _dataString.ToDateTime(new CultureInfo("pt-BR"));
            Assert.AreEqual(_date, new DateTime(2021, 02, 25, 18, 30, 20));

            _dataString = "2009/02/03"; 
            _date = _dataString.ToDateTime(new CultureInfo("en-US"));
            Assert.AreEqual(_date, new DateTime(2009, 02, 03));

            _dataString = "02/25/2021";
            _date = _dataString.ToDateTime(new CultureInfo("en-US"));
            Assert.AreEqual(_date, new DateTime(2021, 02, 25));
        }

        [TestMethod]
        public void Teste_ToDateTimeNull()
        {
            _dataString = "25/02/2021";
            _dateNull = _dataString.ToDateTimeNull(new CultureInfo("pt-BR"));
            Assert.AreEqual(_dateNull, new DateTime(2021, 02, 25));

            _dataString = "2009/02/03";
            _dateNull = _dataString.ToDateTimeNull(new CultureInfo("en-US"));
            Assert.AreEqual(_dateNull, new DateTime(2009, 02, 03));

            _dataString = "2009/99/99";
            _dateNull = _dataString.ToDateTimeNull(new CultureInfo("en-US"));
            Assert.AreEqual(_dateNull, null);
        }

        [TestMethod]
        public void Teste_ToDateTimeDayEnd()
        {
            _dataString = "25/02/2021";
            _date = _dataString.ToDateTime(new CultureInfo("pt-BR"));
            
            DateTime data1 = _date.ToDateTimeDayEnd();
            DateTime data2 = new DateTime(2021, 02, 25, 23, 59, 59, 999);

            Assert.AreEqual(data1, data2);
        }

        [TestMethod]
        public void Teste_ToDateTimeDayEnd_Null()
        {
            _dataString = "25/02/2021";
            _dateNull = _dataString.ToDateTimeNull(new CultureInfo("pt-BR"));

            DateTime data1 = _dateNull.ToDateTimeDayEnd();
            DateTime data2 = new DateTime(2021, 02, 25, 23, 59, 59, 999);

            Assert.AreEqual(data1, data2);
        }
    }
}
