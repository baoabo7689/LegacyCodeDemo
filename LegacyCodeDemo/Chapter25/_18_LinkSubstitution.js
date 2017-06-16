var Chapter25_LinkSubstitution
{
    // SUT.js
    var car =
    {
        move: function () {
            var path = findPath();

            if (!path.length) {
                car.stop();
            }
        },
        stop: function () {
        }
    };

    // Library.js
    function findPath() {
        return [1, 2, 3];
    }

    // RealCode
    // include Library.js
    // include SUT.js

    // Test
    // include Library.js
    // include SUT.js
    // => Error
}

var Chapter25_LinkSubstitution
{
    // SUT.js
    var car =
    {
        move: function () {
            var path = findPath();

            if (!path.length) {
                car.stop();
            }
        },
        stop: function () {
        }
    };

    // Library.js
    function findPath() {
        return [1, 2, 3];
    }

    // RealCode
    // include Library.js
    // include SUT.js

    // Substitute.js
    function findPath() {
        return [];
    }

    // Test
    // include Substitute.js
    // include SUT.js
    // => Ok
}
