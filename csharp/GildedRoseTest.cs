using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void Foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
        }


		[Test]
		public void CaseElixir()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 10 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(-1, Items[0].SellIn);
			Assert.AreEqual(8, Items[0].Quality);

		}

		[Test]
		public void CaseAgedBrie0()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();

			Assert.AreEqual(9, Items[0].SellIn);
			Assert.AreEqual(11, Items[0].Quality);

		}

		[Test]
		public void CaseAgedBrie1()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();

			Assert.AreEqual(9, Items[0].SellIn);
			Assert.AreEqual(50, Items[0].Quality);

		}

		[Test]
		public void CaseBackstage0()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 10 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();

			Assert.AreEqual(14, Items[0].SellIn);
			Assert.AreEqual(11, Items[0].Quality);

		}


		[Test]
		public void CaseBackstage1()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();

			Assert.AreEqual(9, Items[0].SellIn);
			Assert.AreEqual(12, Items[0].Quality);

		}

		[Test]
		public void CaseBackstage2()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();

			Assert.AreEqual(4, Items[0].SellIn);
			Assert.AreEqual(13, Items[0].Quality);

		}

		[Test]
		public void CaseBackstage3()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 10 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();

			Assert.AreEqual(-2, Items[0].SellIn);
			Assert.AreEqual(0, Items[0].Quality);

		}

		[Test]
		public void CaseBackstage4()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();

			Assert.AreEqual(4, Items[0].SellIn);
			Assert.AreEqual(50, Items[0].Quality);

		}

		[Test]
		public void CaseSulfuras()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();

			Assert.AreEqual(0, Items[0].SellIn);
			Assert.AreEqual(80, Items[0].Quality);

		}

		[Test]
		public void CaseConjured0()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = -1, Quality = 10 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();

			Assert.AreEqual("Conjured Mana Cake", Items[0].Name);
			Assert.AreEqual(6, Items[0].Quality);
			Assert.AreEqual(-2, Items[0].SellIn);
		}

		[Test]
		public void CaseConjured1()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 10 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();

			Assert.AreEqual("Conjured Mana Cake", Items[0].Name);
			Assert.AreEqual(9, Items[0].SellIn);
			Assert.AreEqual(8, Items[0].Quality);

		}
	}
}
