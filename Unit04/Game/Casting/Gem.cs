namespace Unit04.Game.Casting{
        /// <summary>
        /// <para>An item of cultural or historical interest.</para>
        /// <para>
        /// The responsibility of a gem is to be desirable
        /// </para>
        /// </summary>
    class Gem : Actor{
        private string _gem;
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Gem(){
            this.SetText("■");
            // this.SetVelocity();
        }
    }
}
