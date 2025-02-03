const sql = require('mssql');
const { dbConfig } = require('./dbConfig.js');

module.exports = {
    executeQuery: async (query) => {
        var result = null;
        try {
            await sql.connect(dbConfig);
            result = await sql.query(query);
            console.dir(result);
        } catch (err) {
            console.error('Error al intentar conectarse:', err);
        } finally {
            sql.close();
        }
        return result.recordset;
    }
}