using System.Collections.Generic;

namespace csharp
{
	public class GildedRose
	{
		IList<Item> Items;
		public GildedRose(IList<Item> Items)
		{
			this.Items = Items;
		}

		public void UpdateQuality()
		{
			foreach (var item in Items)
			{
				if (item.Name != "Aged Brie" &&
				item.Name != "Backstage passes to a TAFKAL80ETC concert" &&
				item.Quality > 0 &&
				item.Name != "Sulfuras, Hand of Ragnaros")
				{
					item.Quality--;

				}
				else
				{
					SetBackStageQuality(item);
				}

				if (item.Name != "Sulfuras, Hand of Ragnaros")
				{
					item.SellIn--;
				}

				if (item.Name == "Conjured Mana Cake" && item.Quality > 0)
				{
					item.Quality--;

				}

				SetQualityItemWithLateSales(item);
			}
		}

		private void SetBackStageQuality(Item item)
		{
			if (item.Quality < 50)
			{
				item.Quality++;

				if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
				{
					if (item.SellIn < 11 && item.Quality < 50)
					{
						item.Quality++;

					}

					if (item.SellIn < 6 && item.Quality < 50)
					{
						item.Quality++;
					}
				}
			}
		}

		private static void SetQualityItemWithLateSales(Item item)
		{
			if (item.SellIn < 0)
			{
				if (item.Name != "Conjured Mana Cake")
				{

					if (item.Name != "Aged Brie")
					{
						if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
						{
							if (item.Quality > 0)
							{
								if (item.Name != "Sulfuras, Hand of Ragnaros")
								{
									item.Quality--;
								}
							}
						}
						else
						{
							item.Quality -= item.Quality;
						}
					}
					else
					{
						if (item.Quality < 50)
						{
							item.Quality++;
						}
					}
				}
				else
				{
					if (item.Quality > 0)
					{
						item.Quality -= 2;
					}
				}
			}
		}
	}
}
