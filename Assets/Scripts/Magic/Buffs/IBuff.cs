using UnityEngine.UI;

public interface IBuff : IClippable
    {
        public string Id { get; }

        public void Initialize(BuffContainer buffContainer);

        public void Deinitialize();

        public void Update(float deltaTime);
    }

