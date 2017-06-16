//namespace Chapter25.ReplaceFunctionWithFunctionPointer_1
//{
//    public class Test
//    {
//        // db.h
//        void db_store(struct receive_record * record, struct time_stamp receive_time);

//        // db.c
//        void db_store(struct receive_record * record, struct time_stamp receive_time)
//            {
//            }
//    }

//    // sut.c
//    // <include db.h>
//    // <include db.c>
//    class database
//    {
//        void save(struct receive_record * record, struct time_stamp receive_time)
//            {
//                db_store(record, receive_time);

//        // ...
//    }
//}

//// test
//// <include db.h>
//// <include db.c>
//void save_XXX_XXX()
//{

//}
//}

//namespace Chapter25.ReplaceFunctionWithFunctionPointer_2
//{
//    public class Test
//    {
//        // db.h
//        void db_store(struct receive_record * record, struct time_stamp receive_time);
//        void (*db_store)(struct receive_record * record, struct time_stamp receive_time);

//        // db.c
//        void db_store(struct receive_record * record, struct time_stamp receive_time)
//            {
//            }
//    }

//    // sut.c
//    // <include db.h>
//    // <include db.c>
//    class database
//    {
//        void save(struct receive_record * record, struct time_stamp receive_time)
//            {
//                db_store(record, receive_time);

//        // ...
//    }
//}

//// test
//// <include db.h>
//// <include db.c>
//void save_XXX_XXX()
//{

//}
//}

//namespace Chapter25.ReplaceFunctionWithFunctionPointer_3
//{
//    public class Test
//    {
//        // db.h
//        void db_store_production(struct receive_record * record, struct time_stamp receive_time);
//        void (*db_store)(struct receive_record * record, struct time_stamp receive_time);

//        // db.c
//        void db_store(struct receive_record * record, struct time_stamp receive_time)
//            {
//            }
//    }

//    // sut.c
//    // <include db.h>
//    // <include db.c>
//    class database
//    {
//        void save(struct receive_record * record, struct time_stamp receive_time)
//            {
//                db_store(record, receive_time);

//        // ...
//    }
//}

//// test
//// <include db.h>
//// <include db.c>
//void save_XXX_XXX()
//{

//}
//}

//namespace Chapter25.ReplaceFunctionWithFunctionPointer_4
//{
//    public class Test
//    {
//        // db.h
//        void db_store_production(struct receive_record * record, struct time_stamp receive_time);
//        void (*db_store)(struct receive_record * record, struct time_stamp receive_time);

//        // db.c
//        void db_store(struct receive_record * record, struct time_stamp receive_time)
//            {
//            }
//    }

//    // sut.c
//    // <include db.h>
//    // <include db.c>
//    class database
//    {
//        void save(struct receive_record * record, struct time_stamp receive_time)
//            {
//                db_store(record, receive_time);

//        // ...
//    }

//    void initializeEnvironment()
//    {
//        database.db_store = db_store_production;
//    }
//}

//// test
//// <include db.h>
//// <include db.c>
//void save_XXX_XXX()
//{

//}
//}

//namespace Chapter25.ReplaceFunctionWithFunctionPointer_5
//{
//    public class Test
//    {
//        // db.h
//        void db_store_production(struct receive_record * record, struct time_stamp receive_time);
//        void (*db_store)(struct receive_record * record, struct time_stamp receive_time);

//        // db.c
//        void db_store_production(struct receive_record * record, struct time_stamp receive_time)
//            {
//            }
//    }

//    // sut.c
//    // <include db.h>
//    // <include db.c>
//    class database
//    {
//        void save(struct receive_record * record, struct time_stamp receive_time)
//            {
//                db_store(record, receive_time);

//        // ...
//    }

//    void initializeEnvironment()
//    {
//        database.db_store = db_store_production;
//    }
//}

//// test
//// <include db.h>
//// <include db.c>
//void save_XXX_XXX()
//{

//}
//}
