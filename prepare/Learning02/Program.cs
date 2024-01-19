class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Binaural";
        job1._jobTitle = "Developer";
        job1._startYear = 1;
        job1._endYear = 2;

        Job job2 = new Job();

        job2._company = "Macdonald";
        job2._jobTitle = "Cashier";
        job2._startYear = 3;
        job2._endYear = 4;

        Resume resume = new Resume();

        resume._name = "Christopher Gómez Dallar";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();


    }
}