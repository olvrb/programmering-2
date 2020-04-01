namespace pedalboard.Models.Knobs
{
    abstract class Knob : BaseEntity
    {
        // Reference the pedal
        public Pedal Pedal { get; set; }

        public abstract string FormatValue();
    }
}
