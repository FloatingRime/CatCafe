public class Cat
{
    public enum CatState
    {
        Wander,
        Idle,
        PlayWithGuest
    }

    public CatState state;
    public float extroversion; //猫咪外向程度
    public int moveSpeed; //移动速度
    public int maxWaitTime; //最长等待时间
    public Transform target;

    //在特定范围内游荡
    public Transform leftdownPoint;
    public Transform rightdownPoint;

    public Animator animator;


    //状态机切换
    private void StateControl(){}

    //动画翻转
    private void Flip(){}

    //随机取点
    private Vector2 GetRandomTargetPoint(){}

    //猫咪游荡
    private void Wander(){}

    //静止函数
    private void Idle(){}

    //【to do】
    public void PlayWithGuest(){}
}
