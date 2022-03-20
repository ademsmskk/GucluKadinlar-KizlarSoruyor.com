using Microsoft.AspNetCore.Mvc;

public class ResponseGeneratorHelper : ControllerBase
{
    public ActionResult ResponseGenerator<T>(ServiceResponse<T> incomingResponse)
    {
        switch (incomingResponse.ResponseCode)
        {
            case ResponseCodeEnum.Success:

            //Account
            case ResponseCodeEnum.AccountCreated:
            case ResponseCodeEnum.GetAllAccountOperationSuccess:
            case ResponseCodeEnum.GetAccountByEmailOperationSuccess:
            case ResponseCodeEnum.UpdateAccountByEmailSuccess:
            case ResponseCodeEnum.UpdateAccountPasswordSuccess:
            case ResponseCodeEnum.AccountBlockSuccess:
            case ResponseCodeEnum.AccountCreateSuccess:
            case ResponseCodeEnum.ChangeVisibilityOfAccountSuccess:

            //Category

            case ResponseCodeEnum.GetAllCategoryOperationSuccess:
            case ResponseCodeEnum.GetAccountByNameOperationSuccess:
            case ResponseCodeEnum.CategoryCreateSuccess:
            case ResponseCodeEnum.CategoryDeleteSuccess:
            case ResponseCodeEnum.CategoryUpdateSuccess:
            //Comment

            case ResponseCodeEnum.CommentUpdateSuccess:
            //Title

            case ResponseCodeEnum.GetAllTitleOperationSuccess:
            case ResponseCodeEnum.TitleCreateSuccess:

            //Post
case ResponseCodeEnum.PostDeleteSuccess:


                {
                    return Ok(incomingResponse);
                    // return Ok(response);
                }

            //Account

            case ResponseCodeEnum.GetAccountByEmailOperationFail:
            case ResponseCodeEnum.UpdateAccountByEmailOperationFail:
            case ResponseCodeEnum.UpdateAccountPasswordOperationFail:
            case ResponseCodeEnum.DuplicateAccountError:
            case ResponseCodeEnum.AccountBlockOperationFail:
            case ResponseCodeEnum.AccountCreateOperationFail:
            case ResponseCodeEnum.ChangeVisibilityOfAccountOperationFail:
            case ResponseCodeEnum.GetAllAccountOperationFail:


            //Category
            case ResponseCodeEnum.GetAllCategoryOperationFail:
            case ResponseCodeEnum.GetAccountByNameOperationFail:
            case ResponseCodeEnum.CategoryCreateOperationFail:
            case ResponseCodeEnum.CategoryDeleteOperationFail:
            case ResponseCodeEnum.CategoryUpdateOperationFail:
            case ResponseCodeEnum.DuplicateCategoryError:

            //Comment
            case ResponseCodeEnum.CommentCreateOperationFail:
            case ResponseCodeEnum.GetCommentByIdOperationFail:
            case ResponseCodeEnum.CommentUpdateOperationFail:
            case ResponseCodeEnum.CommentLikeUpdateOperationFail:

            //Title
            case ResponseCodeEnum.GetAllTitleOperationFail:
            case ResponseCodeEnum.DuplicateTitleError:
            case ResponseCodeEnum.TitleCreateOperationFail:
            case ResponseCodeEnum.TitleDeleteOperationFail:
            case ResponseCodeEnum.TitleUpdateOperationFail:
            case ResponseCodeEnum.GetTitleByNameOperationFail:

            //Role
            case ResponseCodeEnum.RoleOperationFail:
            case ResponseCodeEnum.DuplicateRoleError:

            //User 
            case ResponseCodeEnum.DuplicateUserError:
            case ResponseCodeEnum.UserUpdateOperationFail:
            case ResponseCodeEnum.GetUserByUserNameFail:
            //Post
            case ResponseCodeEnum.PostOperationFail:
            case ResponseCodeEnum.PostDeleteOperationFail:
                {
                    return NotFound(incomingResponse);
                }



            case ResponseCodeEnum.BadRequest:
            case ResponseCodeEnum.CommentDeleteOperationFail:
            case ResponseCodeEnum.OperationFail:
                {
                    return NoContent();
                }
            default:
                {
                    return BadRequest(incomingResponse);
                }
        }
    }
}