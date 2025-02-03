const { executeQuery } = require('./dbMethods.js');

module.exports = {
    createTransaction: async (data) => {
        return await executeQuery(`INSERT INTO transactions(user_id, amount) values(${data.user_id}, ${data.amount})`);
    },
    getTransactions: async () => {
        return await executeQuery('SELECT * FROM transactions');
    },
    getTransactionByIdUser: async (userId) => {
        return await executeQuery('SELECT * FROM transactions where user_id = ' + userId);
    },
}
