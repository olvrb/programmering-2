namespace pedalboard.Models.Knobs
{
    abstract class Knob : BaseEntity
    {
        public Pedal Pedal { get; set; }

        public abstract string FormatValue();
    }
}
