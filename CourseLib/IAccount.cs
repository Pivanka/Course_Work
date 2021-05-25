namespace CourseLib
{
    interface IAccount
    {
        void AddPerfomance(Poster poster, Perfomance toAdd);
        void ViewInformation(Perfomance p);
    }
}