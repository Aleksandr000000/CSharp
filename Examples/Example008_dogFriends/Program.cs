int count =0;
int dictance = 500;
int FirstFriendSpeed=18;
int SecondFriendSpeed=20;
int DogSpeed= 2;
int Friend = 2;
int time = 0;

while (dictance > 10)
{
    if (Friend==1)
    {
    time=dictance/(FirstFriendSpeed+DogSpeed);
    Friend=2;
    dictance=dictance-(FirstFriendSpeed+SecondFriendSpeed)*time;
    count=count+1;
    }
    if (Friend==2)
    {
    time=dictance/(SecondFriendSpeed+DogSpeed);
    Friend=1;
    dictance=dictance-(FirstFriendSpeed+SecondFriendSpeed)*time;
    count=count+1;      
    }
Console.Write(count);
}

