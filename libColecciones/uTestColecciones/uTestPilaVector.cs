using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Vectoriales;

namespace uTestDemoColecciones
    {
    [TestClass]
    public class uTestPilaVector
        {
        #region Atributos de Prueba
        private clsPilaVector<int> testTAD;
        private int[] testItems;
        private int testItem;
        #endregion
        #region Casos de Prueba
        #region Constructores
        #region Constructor NO Parametrizado Por Defecto
        [TestMethod]
        public void uTestConstructorNoParametrizado()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>();
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        #endregion
        #region Constructor con Capacidad
        [TestMethod]
        public void uTestConstructor1CapacidadNegativa()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(-100);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(0);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(500);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(500, testTAD.darItems().Length);
            Assert.AreEqual(500, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadEnBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue / 16);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(int.MaxValue/16, testTAD.darItems().Length);
            Assert.AreEqual(int.MaxValue/16, testTAD.darCapacidad());
            Assert.AreEqual(false, testTAD.esDinamica());
            Assert.AreEqual(0, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadFueraDeBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue / 16 + 1);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadEnMaxValue()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        #endregion
        #region Constructor con Capacidad y Tipo de Flexibilidad
        [TestMethod]
        public void uTestConstructor2CapacidadNegativaFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(-100, true);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadNegativaNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(-100, false);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadCeroFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(0, true);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadCeroNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(0, false);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadNormalFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(500, true);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(500, testTAD.darItems().Length);
            Assert.AreEqual(500, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadNormalNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(500, false);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(500, testTAD.darItems().Length);
            Assert.AreEqual(500, testTAD.darCapacidad());
            Assert.AreEqual(false, testTAD.esDinamica());
            Assert.AreEqual(0, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadMasAllaBordeFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue / 16 + 1, true);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadMasAllaBordeNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue / 16 + 1, false);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadEnMaxValueFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue, true);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadEnMaxValueNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue, false);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        #endregion
        #region Constructor con Capacidad y Factor de Crecimiento
        [TestMethod]
        public void uTestConstructor3CapacidadNegativaFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(-100,-10);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNegativaFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(-100, 0);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNegativaFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(-100, 10);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNegativaFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(-100, int.MaxValue/16+1);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadCeroFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(0,-1);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadCeroFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(0, 0);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadCeroFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(0, 500);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(500, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadCeroFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(0, int.MaxValue / 16 + 1);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadNormalFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(500,-1);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNormalFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(500, 0);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(500, testTAD.darItems().Length);
            Assert.AreEqual(500, testTAD.darCapacidad());
            Assert.AreEqual(false, testTAD.esDinamica());
            Assert.AreEqual(0, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNormalFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(500, 500);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(500, testTAD.darItems().Length);
            Assert.AreEqual(500, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(500, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNormalFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(500, int.MaxValue/16+1);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(00, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadEnBordeFactoCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue / 16,-1);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnBordeFactoCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue / 16, 0);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testTAD.darItems().Length);
            Assert.AreEqual(int.MaxValue / 16, testTAD.darCapacidad());
            Assert.AreEqual(false, testTAD.esDinamica());
            Assert.AreEqual(0, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnBordeFactoCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue / 16, 500);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnBordeFactoCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue / 16, int.MaxValue/16+1);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadFueraDeBordeFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue / 16 + 1, -1);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadFueraDeBordeFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue / 16 + 1, 0);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadFueraDeBordeFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue / 16 + 1, 500);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadFueraDeBordeFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue / 16 + 1, int.MaxValue/16+1);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadEnMaxValueFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue, -1);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnMaxValueFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue, 0);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnMaxValueBordeFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue, 500);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnMaxValueFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testTAD = new clsPilaVector<int>(int.MaxValue, int.MaxValue/16+1);
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        #endregion
        #endregion
        #region Mutadores
        [TestMethod]
        public void uTestPonerItemsConLongitudCero()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.ponerItems(testItems));
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudNormal()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.ponerItems(testItems));
            Assert.AreEqual(3, testTAD.darCapacidad());
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(1, testTAD.darItems()[0]);
            Assert.AreEqual(2, testTAD.darItems()[1]);
            Assert.AreEqual(3, testTAD.darItems()[2]);
            Assert.AreEqual(3, testTAD.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudEnBorde()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItems = new int[int.MaxValue/16];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.ponerItems(testItems));
            Assert.AreEqual(int.MaxValue/16, testTAD.darCapacidad());
            Assert.AreEqual(int.MaxValue / 16, testTAD.darLongitud());
            for (int varIterador = 0; varIterador < int.MaxValue / 16; varIterador++)
                Assert.AreEqual(0, testTAD.darItems()[varIterador]);
            Assert.AreEqual(int.MaxValue / 16, testTAD.darItems().Length);
            Assert.AreEqual(false, testTAD.esDinamica());
            Assert.AreEqual(0, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudMasAllaDelBorde()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItems = new int[int.MaxValue / 16 + 1];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.ponerItems(testItems));
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darItems().Length);
            #endregion
            }

        [TestMethod]
        public void uTestAjustarFlexibilidadCapacidadEnBorde()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>(int.MaxValue/16);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.ajustarFlexibilidad(true));
            Assert.AreEqual(false, testTAD.esDinamica());
            Assert.AreEqual(0, testTAD.darFactorCrecimiento());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testTAD.darCapacidad());
            Assert.AreEqual(int.MaxValue / 16, testTAD.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestAjustaFlexibilidadCapacidadEnCero()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>(0);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.ajustarFlexibilidad(false));
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(0, testTAD.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestAjustarFlexibilidadCapacidadNormal()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>(500);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.ajustarFlexibilidad(false));
            Assert.AreEqual(false, testTAD.esDinamica());
            Assert.AreEqual(0, testTAD.darFactorCrecimiento());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(500, testTAD.darCapacidad());
            Assert.AreEqual(500, testTAD.darItems().Length);
            #endregion
            }

        [TestMethod]
        public void uTestAjustarFactorCrecimientoNormalEnCapacidadNormal()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>(500);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.ajustarFactorCrecimiento(3000));
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(3000, testTAD.darFactorCrecimiento());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(500, testTAD.darCapacidad());
            Assert.AreEqual(500, testTAD.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestAjustarFactorCrecimientoEnBordeEnCapacidadNormal()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>(500);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.ajustarFactorCrecimiento((int.MaxValue/16)-testTAD.darItems().Length));
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(int.MaxValue/16-testTAD.darItems().Length, testTAD.darFactorCrecimiento());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(500, testTAD.darCapacidad());
            Assert.AreEqual(500, testTAD.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestAjustarFactorCrecimientoEnBordeConCapacidadEnBorde()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>(int.MaxValue/16);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.ajustarFactorCrecimiento(int.MaxValue / 16));
            Assert.AreEqual(false, testTAD.esDinamica());
            Assert.AreEqual(0, testTAD.darFactorCrecimiento());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(int.MaxValue/16, testTAD.darCapacidad());
            Assert.AreEqual(int.MaxValue/16, testTAD.darItems().Length);
            #endregion
            }
        #endregion
        #region Accesores
        [TestMethod]
        public void uTestDarItems()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(3, testTAD.darItems().Length);
            Assert.AreEqual(1, testTAD.darItems()[0]);
            Assert.AreEqual(2, testTAD.darItems()[1]);
            Assert.AreEqual(3, testTAD.darItems()[2]);
            #endregion
            }
        [TestMethod]
        public void uTestDarLongitud()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(3, testTAD.darLongitud());
            #endregion
            }
        [TestMethod]
        public void uTestDarCapacidad()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(3, testTAD.darCapacidad());
            #endregion
            }
        [TestMethod]
        public void uTestDarFactorCrecimiento()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        #endregion
        #region Consultores
        [TestMethod]
        public void uTestEsDinamica()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.esDinamica());
            #endregion
            }
        #endregion
        #region CRUDs
        #region Apilar
        [TestMethod]
        public void uTestApilarItemEnTADVacio()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.apilar(123));
            Assert.AreEqual(123, testTAD.darItems()[0]);
            Assert.AreEqual(1, testTAD.darLongitud());
            Assert.AreEqual(1000, testTAD.darCapacidad());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            Assert.AreEqual(true, testTAD.esDinamica());
            #endregion
            }
        [TestMethod]
        public void uTestApilarItemEnTADConItems()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testTAD.apilar(123);  //TODO: ponerCapacidad();
            testTAD.apilar(456);
            testTAD.apilar(789);
            
            testItems = new int[1000];
            testItems[0] = 777;
            testItems[1] = 789;
            testItems[2] = 456;
            testItems[3] = 123;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.apilar(777));
            Assert.AreEqual(1000, testTAD.darCapacidad());
            Assert.AreEqual(4, testTAD.darLongitud());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            Assert.AreEqual(true, testTAD.esDinamica());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestApilarItemEnTADLleno()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItems = new int[3];
            testItems[0] = 123;
            testItems[1] = 456;
            testItems[2] = 789;
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.apilar(777));
            Assert.AreEqual(1003, testTAD.darCapacidad());
            Assert.AreEqual(4, testTAD.darLongitud());
            Assert.AreEqual(777, testTAD.darItems()[0]);
            Assert.AreEqual(123, testTAD.darItems()[1]);
            Assert.AreEqual(456, testTAD.darItems()[2]);
            Assert.AreEqual(789, testTAD.darItems()[3]);
            for (int i = 4; i <= testTAD.darItems().Length-1; i++)
                Assert.AreEqual(0, testTAD.darItems()[i]);
            #endregion
            }
        [TestMethod]
        public void uTestApilarItemEnTADLlenoEnBorde()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItems = new int[int.MaxValue / 16];
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.apilar(777));
            Assert.AreEqual(int.MaxValue/16, testTAD.darCapacidad());
            Assert.AreEqual(int.MaxValue/16, testTAD.darLongitud());
            Assert.AreEqual(false, testTAD.esDinamica());
            Assert.AreEqual(0, testTAD.darFactorCrecimiento());
            Assert.AreEqual(int.MaxValue / 16, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Desapilar
        [TestMethod]
        public void uTestDesapilarEnTADVacio()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.desapilar(ref testItem));
            Assert.AreEqual(-1, testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(0, testTAD.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestDesapilarEnTADConItems()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testTAD.apilar(123);
            testTAD.apilar(456);
            testTAD.apilar(789);
            testItem = 0;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.desapilar(ref testItem));
            Assert.AreEqual(789, testItem);
            Assert.AreEqual(2, testTAD.darLongitud());
            Assert.AreEqual(1000, testTAD.darCapacidad());
            Assert.AreEqual(1000, testTAD.darItems().Length);
            Assert.AreEqual(456, testTAD.darItems()[0]);
            Assert.AreEqual(123, testTAD.darItems()[1]);
            #endregion
            }
        [TestMethod]
        public void uTestDesapilarEnTADLleno()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItems = new int[3];
            testItems[0] = 123;
            testItems[1] = 456;
            testItems[2] = 789;
            testTAD.ponerItems(testItems);
            testItem = 0;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.desapilar(ref testItem));
            Assert.AreEqual(123, testItem);
            Assert.AreEqual(2, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darCapacidad());
            Assert.AreEqual(456, testTAD.darItems()[0]);
            Assert.AreEqual(789, testTAD.darItems()[1]);
            Assert.AreEqual(789, testTAD.darItems()[2]);
            #endregion
            }
        #endregion
        #region Revisar
        [TestMethod]
        public void uTestRevisarEnTADVacio()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItems = new int[0];
            testItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.revisar(ref testItem));
            Assert.AreEqual(-1, testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(0, testTAD.darCapacidad());
            Assert.AreEqual(0, testTAD.darItems().Length);
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRevisarEnTADConItems()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testTAD.apilar(123);
            testTAD.apilar(456);
            testTAD.apilar(789);
            testItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.revisar(ref testItem));
            Assert.AreEqual(789, testItem);
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(1000, testTAD.darCapacidad());
            Assert.AreEqual(1000, testTAD.darItems().Length);
            Assert.AreEqual(789, testTAD.darItems()[0]);
            Assert.AreEqual(456, testTAD.darItems()[1]);
            Assert.AreEqual(123, testTAD.darItems()[2]);
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestRevisarEnTADLleno()
            {
            #region Configurar
            testTAD = new clsPilaVector<int>();
            testItems = new int[3];
            testItems[0] = 123;
            testItems[1] = 456;
            testItems[2] = 789;
            testTAD.ponerItems(testItems);
            testItem = 0;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.revisar(ref testItem));
            Assert.AreEqual(123, testItem);
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darCapacidad());
            Assert.AreEqual(3, testTAD.darItems().Length);
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            Assert.AreEqual(123, testTAD.darItems()[0]);
            Assert.AreEqual(456, testTAD.darItems()[1]);
            Assert.AreEqual(789, testTAD.darItems()[2]);
            #endregion
            }
        #endregion
        #region Reversar
        [TestMethod]
        public void testReversarConTADSemilleno()
            {
            #region Inicializar
            testTAD = new clsPilaVector<int>(5);
            testTAD.apilar(1);
            testTAD.apilar(2);
            testTAD.apilar(3);
            testTAD.apilar(4);
            testItems = new int[5] { 1, 2, 3, 4, 0 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.reversar());
            Assert.AreEqual(4, testTAD.darLongitud());
            Assert.AreEqual(5, testTAD.darCapacidad());
            Assert.AreEqual(5, testTAD.darItems().Length);
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void testReversarConTADLLeno()
            {
            #region Inicializar
            testTAD = new clsPilaVector<int>();
            testItems = new int[4] { 1, 2, 3, 4 };
            testTAD.ponerItems(testItems);
            testItems = new int[4] { 4, 3, 2, 1 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.reversar());
            Assert.AreEqual(4, testTAD.darLongitud());
            Assert.AreEqual(4, testTAD.darCapacidad());
            Assert.AreEqual(4, testTAD.darItems().Length);
            Assert.AreEqual(true, testTAD.esDinamica());
            Assert.AreEqual(1000, testTAD.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void testReversarConTADVacio()
            {
            #region Inicializar
            testItems = new int[4] { 0, 0, 0, 0 };
            testTAD = new clsPilaVector<int>(4);
            #endregion
            #region Comprobar y Comprobar
            Assert.AreEqual(false, testTAD.reversar());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(4, testTAD.darCapacidad());
            Assert.AreEqual(4, testTAD.darItems().Length);
            Assert.AreEqual(true, testTAD.esDinamica());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        }
    }
