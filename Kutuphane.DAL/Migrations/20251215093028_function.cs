using Microsoft.EntityFrameworkCore.Migrations;


#nullable disable

namespace Kutuphane.DAL.Migrations
{
    /// <inheritdoc />
    public partial class function : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

                CREATE OR ALTER FUNCTION fn_LoginKontrol
                (
                    @UserName nvarchar(20)
                    , @Password nvarchar(250)
                )
                RETURNS BIT
                AS
                BEGIN

                    --Declare the return variable here
                    DECLARE @ResultVar BIT = 0

                    -- Add the T - SQL statements to compute the return value here
                    IF EXISTS(SELECT TOP 1 PersonelId FROM Personeller WITH(NOLOCK) Where KullaniciAdi = @UserName AND Sifre = @Password AND AktifMi = 1)

                        BEGIN
                            SELECT @ResultVar = 1

                        END

                    -- Return the result of the function

                    RETURN @ResultVar

                END
                GO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION [dbo].[fn_LoginKontrol]");
        }
    }
}
