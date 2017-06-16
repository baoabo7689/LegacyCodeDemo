//namespace Chapter25.TextRedefinition_1
//{
//    # Account.rb
//    class Account
//        def report_deposit(value)
//            ...
//        end

//        def deposit(value)
//            report_deposit(value)
//            @balance +=value
//        end

//        def withdraw(value)
//            @balance -=value
//        end
//    end
//}

//namespace Chapter25.TextRedefinition_2
//{
//    # AccountTests.rb
//    require "runit/testcase"
//    require "Account"
//    class Account
//        def report_deposit(value)
//            // Redefinition
//        end
//    end

//    # test start here
//    class AccountTest < RUNIT::TestCase
//        ...
//    end
//}
