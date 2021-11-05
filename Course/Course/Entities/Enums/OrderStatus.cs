
namespace Course.Entities.Enums     //pasta
{
    enum OrderStatus : int          //enumeracao status das compras
    {
        PendingPayment = 0,               //numeros do index
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}