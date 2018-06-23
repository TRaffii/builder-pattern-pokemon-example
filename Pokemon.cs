namespace Builder
{
    enum PokemonType
    {
        Water,
        Rock,
        Fire,
        Air,
        Electric,
        Poison
    }

    class Pokemon
    {
        private string _name;
        private string _color;
        private int _age;
        private PokemonType _type;
        private int _level;

        public Pokemon(Builder builder)
        {
            _name = builder._name;
            _color = builder._color;
            _age = builder._age;
            _type = builder._type;
            _level = builder._level;
        }

        public class Builder
        {
            internal string _name;
            internal string _color;
            internal int _age;
            internal PokemonType _type;
            internal int _level;

            public Builder WithName(string name)
            {
                _name = name;
                return this;
            }

            public Builder WithColor(string color)
            {
                _color = color;
                return this;
            }

            public Builder WithAge(int age)
            {
                _age = age;
                return this;
            }

            public Builder HasType(PokemonType type)
            {
                _type = type;
                return this;
            }

            public Builder OnLevel(int level)
            {
                _level = level;
                return this;
            }

            public static implicit operator Pokemon(Builder builder)
            {
                return new Pokemon(builder);
            }
        }
    }
}