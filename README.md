# tests-for-prize-wheel
Contains the tests and logger for the Prize Wheel Unity C# project.

# Test Manager
#### initializeCaseAndProbability()
Initializes the probability ranges for each prize wheel reward outcome for the purposes of testing.

#### correctCaseNumberTest()
Verifies that the randomNumber generated by Wheel_Animation_Manager is fed into the correct probability range.

#### correctRewardTest()
Verifies that the reward generated corresponds to the correct reward in the Wheel_Animation_Manager.rewards enum.

# Logger
Creates a log file if it does not exist, and if it does, appends test success and failure messages to the log file, along with the current DateTime.
