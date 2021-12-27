namespace ExemploPOO.Models
{
    public class ContaCorrente : Conta
    {
        public override void creditar(double value)
        {
            base.saldo = value;
        }
    }
}