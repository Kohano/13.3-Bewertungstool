using Bewertungstool;

namespace BewertungstoolTests
{
    [TestClass]
    public class NoteTests
    {
        [TestMethod]
        [DataRow(100, 0, 0.00, 6.00, "6", "ungenügend")]
        [DataRow(100, 20, 0.20, 6.00, "6", "ungenügend")]
        [DataRow(100, 21, 0.26, 5.30, "5-", "mangelhaft")]
        [DataRow(100, 26, 0.26, 5.30, "5-", "mangelhaft")]
        //[DataRow(0.33   ,5.00    ,"5"  , "mangelhaft")]
        //[DataRow(0.39 ,	4.70 ,	"5+" ,	"mangelhaft")]
        //[DataRow(0.44 ,	4.30 ,	"4-" ,	"ausreichend")]
        //[DataRow(0.50 ,	4.00 ,	"4" ,	"ausreichend")]
        //[DataRow(0.55 ,	3.70 ,	"4+" 	,"ausreichend")]
        //[DataRow(0.60 ,	3.30 ,	"3-" ,	"befriedigend")]
        //[DataRow(0.65 ,	3.00 ,	"3" 	,"befriedigend")]
        //[DataRow(0.70 ,	2.70 ,	"3+" ,	"befriedigend")]
        //[DataRow(0.75 ,	2.30 ,	"2-" 	,"gut")]
        //[DataRow(0.80 ,	2.00 ,	"2" ,	"gut")]
        //[DataRow(0.85 	,1.70 ,	"2+" ,	"gut")]
        //[DataRow(0.90 ,	1.30 ,	"1-" 	, "sehr gut")]
        //[DataRow(0.95 ,	1.00 ,	"1" 	,"sehr gut")]
        //[DataRow(1.00 ,	0.70 ,	"1+" ,	"sehr gut")]

        public void Note_Erstellbar(int moeglichePunkte, int erreichtePunkte, double prozent,double dezimal, string kurz, string lang)
        {
            // Arrange
            // Act
            Note n = new Note(moeglichePunkte, erreichtePunkte);

            // Assert
            Assert.AreEqual(moeglichePunkte, n.MoeglichePunkte);
            Assert.AreEqual(erreichtePunkte, n.ErreichtePunkte);
            Assert.AreEqual(prozent, n.Prozent);
            Assert.AreEqual(dezimal, n.Dezimal);
            Assert.AreEqual(kurz, n.Kurz);
            Assert.AreEqual(lang, n.Lang);
        }
    }
}