public class MemDec
{
   public bool[] Value { get; set }
   public MemDec(in int value) => Value = Array.Reverse(new BitArray(value).Cast<bool>());
   publig decimal GetValue() => Convert.ToInt64(new string(Value.Select(x => x ? '1' : '0')), 2);
}
