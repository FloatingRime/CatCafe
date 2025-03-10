//代码规范
//变量名小写开头，驼峰式
//函数名大写开头，驼峰式



public class Guest
{
    public int payment; //顾客付的钱
    public int mood; //顾客心情
    public float payProbability; //顾客付钱概率
    public float catLikeProbility; //受猫猫喜欢概率
    public Dictionary<Cat,int> catLikability; //记录每只猫猫和该顾客的好感度

    //通过喜欢概率判断是否有机会和猫猫玩，有机会就玩（向猫猫走去
    public void PlayWithCat(Cat cat); 

    //这个是猫来找顾客玩，需要重载，还没想好怎么重载
    public void PlayWithCat(Cat cat, int a);

    //好感度改变函数
    public void CatLikeChange(Cat cat, int likeChange);

    //好感查询函数
    //...

    //付钱概率改变函数
    public void PayProbabilityChange();

    //顾客移动函数，在店内游荡，碰见猫猫并触发play函数
    public void Move();

    //付钱函数
    public void Pay();
}