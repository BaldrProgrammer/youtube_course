// явное преобразование
float floatnum = 10.5f;
int intnum = (int)floatnum;
Console.WriteLine(intnum);


// неявное преобразование
int num = 123;
double doublenum = num;
Console.WriteLine(doublenum);
    
    
// вроде явное, хз
bool isStudent = true;
int isStudentInt = Convert.ToInt32(isStudent); // нельзя с бул переменную запихнуть инт
string isStudentStr = Convert.ToString(isStudentInt); // та же схема 
