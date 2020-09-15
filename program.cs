class person
    {
        class student : person
        {
        class teacher : person
        {
        
        class StudentAndTeacherTest : person
        {
        
        person myperson = new person()
        myperson.Greet("Hello");

        student mystudent = new student()
        mystudent.SetAge(21)
        mystudent.Greet("Hello")
        mystudent.ShowAge(21);

        teacher myteacher = new teacher ()
        myteacher.SetAge(30)
        myteacher.Greet("Hello")
        myteacher.Explain("Subject");

        person myPerson = new person()
        myPerson.SetAge(20);

        student myStudent = new student ()
        mystudent.GoToClasses("I'm going to class.")
        mystudent.ShowAge("20");

        teacher myteacher = new teacher ()
        myteacher.Explain("Subject");

        protected int age;
        public void Greet ()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge (int n)
        {
            age = n;
        }
        
        }