using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketAI.API.Models
{
    public class SelfCostModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public long ProductId { get; set; }

        public UserModel Owner { get; set; }
        public int OwnerId { get; set; }

        [NotMapped]
        public double CurrentPrice { get; set; }


        public double PurchaseCost { get; set; }
        public double PackagingCost { get; set; }
        public double DeliveryToYourStockCost { get; set; }
        public double DeliveryToWbStockCost { get; set; }
        public double FFServicesCost { get; set; }
        public double PhotographCost { get; set; }

        [NotMapped]
        public double TotalSelfCost =>    PhotographCost
                                        + FFServicesCost
                                        + DeliveryToWbStockCost
                                        + DeliveryToYourStockCost
                                        + PackagingCost
                                        + PurchaseCost;
    }
}
