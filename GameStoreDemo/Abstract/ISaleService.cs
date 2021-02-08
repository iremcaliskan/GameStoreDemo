using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Abstract
{
    public interface ISaleService
    {
        void Sale(Player player, Game game, Campaign campaign);
        void DiscountSend(Player player, Game game, Campaign campaign);

    }
}
