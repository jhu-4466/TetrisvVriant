while [[ $# -gt 0 ]]; do
  key="$1"
  case $key in
    -m|--message)
      if [ -z "$2" ]; then
        echo "Error: Commit message cannot be empty."
        exit 1
      fi
      commit_message="$2"
      shift # past argument
      shift # past value
      ;;
    -b|--branch)
      if [ -z "$2" ]; then
        echo "Error: Branch name cannot be empty."
        exit 1
      fi
      branch="$2"
      shift # past argument
      shift # past value
      ;;
    *)
      # Unknown option
      shift # past argument
      ;;
  esac
done

git add .
git commit -m "$commit_message"
git push origin "$branch"