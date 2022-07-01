bool Second_task_1(int numberTask2)
{
  Console.WriteLine("Input:");
  if (numberTask2%7==0 && numberTask2%23==0) 
      return true;
  else
      return false;

}
int task2 = Convert.ToInt32(Console.ReadLine());
Second_task_1(task2);