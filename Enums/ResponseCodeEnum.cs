public enum ResponseCodeEnum
{
    Success,
    DuplicateAccountError,
    UserNotFound,
    OperationFail,
    //Account
    AccountCreated,
    GetAllAccountOperationSuccess,
    GetAllAccountOperationFail,
    GetAccountByEmailOperationSuccess,
    GetAccountByEmailOperationFail,
    UpdateAccountByEmailSuccess,
    UpdateAccountByEmailOperationFail,
    UpdateAccountPasswordSuccess,
    UpdateAccountPasswordOperationFail,
    AccountBlockSuccess,
    AccountBlockOperationFail,
    AccountCreateSuccess,
    AccountCreateOperationFail,
    ChangeVisibilityOfAccountSuccess,
    ChangeVisibilityOfAccountOperationFail,
    //Category
    GetAllCategoryOperationSuccess,
    GetAllCategoryOperationFail,
    GetAccountByNameOperationSuccess,
    GetAccountByNameOperationFail,
    CategoryCreateSuccess,
    CategoryCreateOperationFail,
    CategoryDeleteSuccess,
    CategoryDeleteOperationFail,
    CategoryUpdateSuccess,
    CategoryUpdateOperationFail,
    DuplicateCategoryError,
  //Comment
  CommentCreateOperationFail, 
  CommentDeleteOperationFail,
  GetCommentByIdOperationFail,
  CommentUpdateSuccess,
  CommentUpdateOperationFail,
  CommentLikeUpdateOperationFail,
  //Title
  GetAllTitleOperationSuccess,
  GetAllTitleOperationFail,
  TitleCreateSuccess,
  DuplicateTitleError,
  TitleCreateOperationFail,
  TitleDeleteOperationFail,
  TitleUpdateOperationFail,
  GetTitleByNameOperationFail,
  //Role
  RoleOperationFail,
  DuplicateRoleError,

 //User
 DuplicateUserError, 
 UserUpdateOperationFail,
 GetUserByUserNameFail,
      BadRequest = 400,
    GetAllPetHelperSuccess,
    GetAllPetHelperFail,
    FindPetHelperByLatLongSuccess,
    FindPetHelperByLatLongFail,
    PetHelperAddSuccess,
    PetHelperAddFail,

    //Post
PostOperationFail,
PostDeleteSuccess,
PostDeleteOperationFail,
    


    
    

}