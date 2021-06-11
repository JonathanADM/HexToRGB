using NUnit.Framework;
using HexToRGB;

namespace HexToRGBTest
{
    public class HexToRGBClassTeststs
    {
        [SetUp]
        public void Setup()
        {
            //Hex -> 6 digitos -> base 16
            //0-9 y 10-15 -> A-F
            //FF00D4
            //RGB(r,g,b) -> 0-255
            //r=FF, g=00, b=D4
            //FF = 15(16) + 15 = 255
            //00 = 0(16) + 0 % 16 = 0     }RGB(255,0,212)
            //D4 = 13(16) + 4 % 16 = 212
        }

        [Test]
        public void ConvertToRGB_Test()
        {
            HexToRGBClass h = new HexToRGBClass();
            string hex = "FF00D4";
            int[] expected = { 255, 0, 212 };

            Assert.AreEqual(expected, h.ConvertToRGB(hex));
        }
        [Test]
        public void ConvertToRGB_Test_Uppercase()
        {
            HexToRGBClass h = new HexToRGBClass();
            string hex = "ff00D4";
            int[] expected = { 255, 0, 212 };

            Assert.AreEqual(expected, h.ConvertToRGB(hex));
        }
        [Test]
        public void ConvertToRGB_Test_Input()
        {
            HexToRGBClass h = new HexToRGBClass();
            string hex = "ff00D454";
            Assert.That(() => h.ConvertToRGB(hex), Throws.ArgumentException); 
        }

        [Test]
        public void CharToInt_Test()
        {
            HexToRGBClass h = new HexToRGBClass();
            char hex = 'F';
            Assert.AreEqual(15, h.CharToInt(hex));
        }
        [Test]
        public void CharToInt_Test_Character_Exception()
        {
            HexToRGBClass h = new HexToRGBClass();
            char hex = 'M';
            Assert.That(() => h.CharToInt(hex), Throws.ArgumentException);
        }
    }
}