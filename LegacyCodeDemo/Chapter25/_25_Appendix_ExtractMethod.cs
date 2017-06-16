namespace Chapter25.Appendix_ExtractMethod
{
    public class Coffee
    {
        public double Sugar = 100;

        public void Mix(double milk)
        {
            if (milk > 80)
            {
                Sugar -= 20;
            }
            else
            {
                Sugar -= 10;
            }
        }
    }
}

namespace Chapter25.Appendix_ExtractMethod_1
{
    public class Coffee
    {
        public double Sugar = 100;

        public void Mix(double milk)
        {
            //if (milk > 80)
            //{
            //    Sugar -= 20;
            //}
            //else
            //{
            //    Sugar -= 10;
            //}
        }
    }
}

namespace Chapter25.Appendix_ExtractMethod_2
{
    public class Coffee
    {
        public double Sugar = 100;

        public void Mix(double milk)
        {
            //if (milk > 80)
            //{
            //    Sugar -= 20;
            //}
            //else
            //{
            //    Sugar -= 10;
            //}
        }

        public void ReduceSugarAmount()
        {
        }
    }
}

namespace Chapter25.Appendix_ExtractMethod_3
{
    public class Coffee
    {
        public double Sugar = 100;

        public void Mix(double milk)
        {
            //if (milk > 80)
            //{
            //    Sugar -= 20;
            //}
            //else
            //{
            //    Sugar -= 10;
            //}

            ReduceSugarAmount();
        }

        public void ReduceSugarAmount()
        {
        }
    }
}

//namespace Chapter25.Appendix_ExtractMethod_4_5
//{
//    public class Coffee
//    {
//        public double Sugar = 100;

//        public void Mix(double milk)
//        {
//            //if (milk > 80)
//            //{
//            //    Sugar -= 20;
//            //}
//            //else
//            //{
//            //    Sugar -= 10;
//            //}

//            ReduceSugarAmount();
//        }

//        public void ReduceSugarAmount()
//        {
//            if (milk > 80)
//            {
//                Sugar -= 20;
//            }
//            else
//            {
//                Sugar -= 10;
//            }
//        }
//    }
//}

namespace Chapter25.Appendix_ExtractMethod_6
{
    public class Coffee
    {
        public double Sugar = 100;

        public void Mix(double milk)
        {
            //if (milk > 80)
            //{
            //    Sugar -= 20;
            //}
            //else
            //{
            //    Sugar -= 10;
            //}

            ReduceSugarAmount(milk);
        }

        public void ReduceSugarAmount(double milk)
        {
            if (milk > 80)
            {
                Sugar -= 20;
            }
            else
            {
                Sugar -= 10;
            }
        }
    }
}

namespace Chapter25.Appendix_ExtractMethod_7_8
{
    public class Coffee
    {
        public double Sugar = 100;

        public void Mix(double milk)
        {
            ReduceSugarAmount(milk);
        }

        public void ReduceSugarAmount(double milk)
        {
            if (milk > 80)
            {
                Sugar -= 20;
            }
            else
            {
                Sugar -= 10;
            }
        }
    }
}