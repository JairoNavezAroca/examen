module.exports = {
    dbConfig: {
        user: 'sa',
        password: '123',
        server: 'localhost',
        port: 1434,
        database: '_Examen',
        dialect: "mssql",
        options: {
            encrypt: false,
            trustServerCertificate: true,
            trustedConnection: true,
        },
    }
}