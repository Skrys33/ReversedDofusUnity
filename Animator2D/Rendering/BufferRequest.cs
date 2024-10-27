
namespace Ankama.Animator2D.Rendering
{
    internal struct BufferRequest
    {
        public readonly Animations.Animator2D target;
        public readonly AnimationInstance animation;
        public int id;

        public BufferRequest(Animations.Animator2D target, AnimationInstance animation, int id)
        {
            this.target = target;
            this.animation = animation;
            this.id = id + 1;
        }
    }
}
