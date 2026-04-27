# CTU Simple ATM System
**Project Name:** SimpleATMSystemSectionAQ2
**Module:** SDT621 - Formative Assessment 1 (Section A Q2)

## Project Description
A console application simulating a banking ATM transaction. It identifies the use, accepts a starting balance and processes a withdrawal request while ensuring the account does not go into a negative balance.

## Features
- **Branded Interface**: Magenta headers for the "CTU Simple ATM System" brand.
- **Robust Transaction Logic**: Prevents withdrawals that exceed the current balance.
- **SA Localization**: Formats currency output using the comma (`,`) decimal separator as per South African standards.
- **Timestamping**: Displays the exact date and time of the transaction for audit purposes.

## Technical Details
- **Logic**: Implements a dedicated `GetValidNumericInput` method to centralize validation and prevent application crashes.
- **Feedback**: Uses Blue for successful navigation and Red for "Insufficient Funds" alerts.
